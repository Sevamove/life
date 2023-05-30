using Infrastructure.Entities;
using Newtonsoft.Json;

namespace Infrastructure.Adapters
{
	public class JsonFileAdapter<T> : IDataStorageAdapter<T>
	{
		private readonly string[] filePaths;

		public JsonFileAdapter(string[] filePaths)
		{
			this.filePaths = filePaths;
			this.ValidateFileExists();
		}

		public async Task<List<T>> SaveAllAsync(List<T> data)
		{
			this.ValidateFileExists();

			// Load the existing JSON data from the file.
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
			await File.WriteAllTextAsync(this.filePaths[0], updatedJsonString); // TODO: Let the user choose where to write the data..

			Console.WriteLine("New item(s) added to the JSON file.");

			return data;
		}

		public async Task<List<T>?> FindAllAsync()
		{
			List<T>? result = new List<T>();

			for (int i = 0; i < this.filePaths.Length; i++)
			{
				string jsonString = await File.ReadAllTextAsync(this.filePaths[i]);

				try
				{
					List<T>? data = await this.DeserializeAsync<T>(jsonString);

					if (data != null)
					{
						for (int j = 0; j < data.Count; j++)
						{
							result.Add(data[j]);
						}
					}
				}
				catch (Exception error)
				{
					Console.WriteLine(error);
					throw; // Rethrow the exception to observe the details in the debugger
				}
			}

			return result;
		}

		public async Task<T?> FindByIdAsync<T>(string id) where T : BaseEntity
		{
			for (int i = 0; i < this.filePaths.Length; i++)
			{
				string jsonString = await File.ReadAllTextAsync(this.filePaths[i]);
				List<T>? data = await this.DeserializeAsync<T>(jsonString);

				if (data == null)
				{
					return default(T);
				}

				T? item = data.Find(x => x.Id.Equals(id));

				return item;
			}

			return null;
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
			for (int i = 0; i < this.filePaths.Length; i++)
			{
				if (!File.Exists(this.filePaths[i]))
				{
					Console.WriteLine("File not found: " + this.filePaths[i]);
					throw new FileNotFoundException("File not found: " + this.filePaths[i]);
				}
			}
		}
	}
}