namespace HRMangementApi.Models
{
	public class File
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Extenstion { get; set; }

		public byte[] FileData { get; set; }
	}
}
