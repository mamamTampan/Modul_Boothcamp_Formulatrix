using System;
using System.Net;
using Newtonsoft.Json;

public class AdviceFetcher : IDisposable
{
	private bool _disposed = false;
	private WebClient _webClient;

	public AdviceFetcher()
	{
		_webClient = new WebClient();
	}

	public string FetchRandomAdvice()
	{
		string adviceUrl = "https://api.adviceslip.com/advice";
		string jsonContent = _webClient.DownloadString(adviceUrl);
		dynamic adviceData = JsonConvert.DeserializeObject(jsonContent);
		return adviceData.slip.advice;
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (disposing)
			{
				if (_webClient != null)
				{
					_webClient.Dispose();
				}
			}

			_disposed = true;
		}
	}

	~AdviceFetcher()
	{
		Dispose(false);
	}
}

class Program
{
	public static void Main()
	{
		using (AdviceFetcher adviceFetcher = new AdviceFetcher())
		{
			string randomAdvice = adviceFetcher.FetchRandomAdvice();
			Console.WriteLine("Advice tudei: " + randomAdvice);
		}
	}
}