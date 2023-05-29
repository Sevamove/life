using Infrastructure.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Infrastructure.Adapters
{
	public class JsonFileAdapter<T> : IDataStorageAdapter<T>
	{
		private readonly string filePath;

		public JsonFileAdapter(string filePath)
		{
			this.filePath = filePath;
			this.ValidateFileExists();
		}

		public async Task<List<T>> SaveAllAsync(List<T> data)
		{
			this.ValidateFileExists();

			// Load the existing JSON data from the file.
			System.Console.WriteLine("FIRST");
			List<T>? jsonData = await this.FindAllAsync();

			// Create a new list of items if it doesn't already exist.
			if (jsonData == null)
			{
				jsonData = new List<T>();
			}

			// Add the new item(s) to the existing list.
			jsonData.AddRange(data);

			// Serialize the updated list of items back into JSON.
			string updatedJsonString = this.Serialize(jsonData);

			// Write the serialized JSON back to the file, overwriting the existing content.
			await File.WriteAllTextAsync(this.filePath, updatedJsonString);

			Console.WriteLine("New item(s) added to the JSON file.");

			return data;
		}

		public async Task<List<T>?> FindAllAsync()
		{
			System.Console.WriteLine("SECOND");
			string jsonString = await File.ReadAllTextAsync(this.filePath);

			try
			{
				System.Console.WriteLine("THIRD");
				List<T>? data = await this.DeserializeAsync<T>(jsonString);
				System.Console.WriteLine("FOURTH");
				return data;
			}
			catch (Exception error)
			{
				Console.WriteLine("FIFTH");
				Console.WriteLine(error);
				throw; // Rethrow the exception to observe the details in the debugger
			}
		}

		public async Task<T?> FindByIdAsync<T>(string id) where T : BaseEntity
		{
			string jsonString = await File.ReadAllTextAsync(this.filePath);
			List<T>? data = await this.DeserializeAsync<T>(jsonString);

			if (data == null)
			{
				return default(T);
			}

			T? item = data.Find(x => x.Id.Equals(id));

			return item;
		}

		internal string Serialize(List<T> data)
		{
			return JsonConvert.SerializeObject(data, Formatting.Indented);
		}

		internal async Task<List<T>?> DeserializeAsync<T>(string json)
		{
			return await Task.Run(() => JsonConvert.DeserializeObject<List<T>>(json));
		}

		private void ValidateFileExists()
		{
			if (!File.Exists(this.filePath))
			{
				Console.WriteLine("File not found: " + this.filePath);
				throw new FileNotFoundException("File not found: " + this.filePath);
			}
		}
	}
}