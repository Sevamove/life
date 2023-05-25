using Infrastructure.Entities;
using Newtonsoft.Json;

namespace Infrastructure.Adapters;

public class JsonFileAdapter<T> : IDataStorageAdapter<T>
{
	private readonly string filePath;

	public JsonFileAdapter(string filePath)
	{
		this.filePath = filePath;
		this.validateFileExists();
	}

	public async Task<List<T>> SaveAllAsync(List<T> data)
	{
		this.validateFileExists();

		// Load the existing JSON data from the file.
		List<T>? jsonData = await this.FindAllAsync();

		// Create a new array of items if not already exists.
		if (jsonData == null)
		{
			jsonData = new List<T>();
		}

		// Add the new item(s) to the existing list.
		foreach (var item in data)
		{
			jsonData.Add(item);
		}

		// Serialize the updated list of items back into JSON.
		string updatedJsonString = this.serialize(jsonData);

		// Write the serialized JSON back to the file, overwriting the existing content.
		File.WriteAllText(this.filePath, updatedJsonString);

		Console.WriteLine("New item(s) added to the JSON file.");

		return data;
	}

	public async Task<List<T>?> FindAllAsync()
	{
		string jsonString = await File.ReadAllTextAsync(this.filePath);

		if (jsonString == null || jsonString == "")
		{
			jsonString = "{}";
		}

		try
		{
			List<T>? data = this.deserialize<T>(jsonString);
			return data;
		}
		catch (Exception error)
		{
			// Handle the exception accordingly (e.g., log an error, return a default value, etc.)
			Console.WriteLine(error);
			return null;
		}
	}

	public async Task<T?> FindByIdAsync<T>(string id) where T : BaseEntity
	{
		string jsonString = await File.ReadAllTextAsync(this.filePath);
		List<T>? data = this.deserialize<T>(jsonString);

		if (data == null)
		{
			return default(T);
		}

		// TODO: solve "Dereference of a possibly null reference."
		T? item = data.Find(x => x.Id.Equals(id));

		return item;
	}

	internal string serialize(List<T> data)
	{
		return JsonConvert.SerializeObject(data, Formatting.Indented);
	}

	internal List<T>? deserialize<T>(string json)
	{
		return JsonConvert.DeserializeObject<List<T>>(json);
	}

	private void validateFileExists()
	{
		if (!File.Exists(this.filePath))
		{
			// TODO: figure out how to handle exception properly: Console or Exception.
			Console.WriteLine("File not found.", this.filePath);
			throw new FileNotFoundException("File not found.", this.filePath + Directory.GetCurrentDirectory());

			// return null;
		}
	}
}
