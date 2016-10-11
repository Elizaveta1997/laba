using System;
namespace client_bibl
{
	public class Clibibl
	{
		public string download(int variant)
		{


			if (variant == 1)
			{
				string url = "http://127.0.0.1:8080/date";
				using (var webClient = new System.Net.WebClient())
					return webClient.DownloadString(url);
			}
			else if (variant == 2)
			{
				string url = "http://127.0.0.1:8080/time";
				using (var webClient = new System.Net.WebClient())
					return webClient.DownloadString(url);
			}
			else {
				string url = "http://127.0.0.1:8080/";
				using (var webClient = new System.Net.WebClient())
					return webClient.DownloadString(url);
			}

		}
	}
}
