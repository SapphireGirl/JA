
public class JAFilestream
{


	public async void CreateCopyOfFile()  
	{  
		string dir = @"c:\Mukesh\files\";  
  
		using (StreamReader objStreamReader= File.OpenText(dir + "test.txt"))  
		{  
			using (StreamWriter objStreamWriter= File.CreateText(dir+ "copy_test.txt"))  
			{  
				await CopyFileToTarget(objStreamReader, objStreamWriter);  
			}  
		}  
	}  
  
	public async Task CopyFileToTarget(StreamReader objStreamReader, StreamWriter objStreamWriter)   
	{   
		int num;   
		char[] buffer = new char[0x1000];   
  
		while ((num= await objStreamReader.ReadAsync(buffer, 0, buffer.Length)) != 0)   
		{  
			await objStreamWriter.WriteAsync(buffer, 0, num);  
		}   
	}  

}