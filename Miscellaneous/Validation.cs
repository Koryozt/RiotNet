using RiotNet.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Miscellaneous
{
	public static class Validation
	{
		public static void ValidateStatusCode(HttpResponseMessage response)
		{
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpMethodException(((int)response.StatusCode));
			}
		}

		public static void ValidatePortOpened()
		{
			using (TcpClient tcpClient = new TcpClient())
			{
				try
				{
					tcpClient.Connect("127.0.0.1", 2999);
					if (tcpClient.Connected)
						tcpClient.Close();
				}
				catch (Exception)
				{
					throw new GameNotStartedException();

				}
			}
		}

		public static void ValidateServerCertificate()
		{
			using (HttpClientHandler handler = new HttpClientHandler())
			{
				handler.ServerCertificateCustomValidationCallback = VerifyServerCertificate!;
			}
		}

		private static bool VerifyServerCertificate(HttpRequestMessage sender, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			try
			{
				string cert = RiotNetAPI.CertificateFilePath;
				X509Certificate2 ca = new X509Certificate2(cert);

				X509Chain chain2 = new X509Chain();

				chain2.ChainPolicy.ExtraStore.Add(ca);
				chain2.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
				chain2.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;

				bool isValid = chain2.Build(certificate);
				X509Certificate2 chainRoot = chain2.ChainElements[chain2.ChainElements.Count - 1].Certificate;
				isValid = isValid && chainRoot.RawData.SequenceEqual(ca.RawData);

				Debug.Assert(isValid == true);

				return isValid;
			}
			catch (Exception)
			{
				throw;
			}


		}
	}
}