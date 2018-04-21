using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace MockableHttp
{
	public class HttpService : IHttpService
	{
		public HttpService()
		{
			Client = new HttpClient();
		}

		public HttpService(HttpMessageHandler handler)
		{
			Client = new HttpClient(handler);
		}

		public HttpService(HttpMessageHandler handler, bool disposeHandler)
		{
			Client = new HttpClient(handler, disposeHandler);
		}

		public virtual HttpRequestHeaders DefaultRequestHeaders => Client.DefaultRequestHeaders;

		public virtual Uri BaseAddress
		{
			get => Client.BaseAddress;
			set => Client.BaseAddress = value;
		}

		public virtual long MaxResponseContentBufferSize
		{
			get => Client.MaxResponseContentBufferSize;
			set => Client.MaxResponseContentBufferSize = value;
		}

		public virtual TimeSpan Timeout
		{
			get => Client.Timeout;
			set => Client.Timeout = value;
		}

		protected HttpClient Client { get; set; }

		public virtual void CancelPendingRequests()
		{
			Client.CancelPendingRequests();
		}

		public virtual async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return await Client.DeleteAsync(requestUri, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			return await Client.DeleteAsync(requestUri, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> DeleteAsync(string requestUri)
		{
			return await Client.DeleteAsync(requestUri);
		}

		public virtual async Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			return await Client.DeleteAsync(requestUri);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(string requestUri)
		{
			return await Client.GetAsync(requestUri);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			return await Client.GetAsync(requestUri, completionOption);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return await Client.GetAsync(requestUri, completionOption, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			return await Client.GetAsync(requestUri, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			return await Client.GetAsync(requestUri);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return await Client.GetAsync(requestUri, completionOption);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return await Client.GetAsync(requestUri, completionOption, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return await Client.GetAsync(requestUri, cancellationToken);
		}

		public virtual async Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			return await Client.GetByteArrayAsync(requestUri);
		}

		public virtual async Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
			return await Client.GetByteArrayAsync(requestUri);
		}

		public virtual async Task<Stream> GetStreamAsync(string requestUri)
		{
			return await Client.GetStreamAsync(requestUri);
		}

		public virtual async Task<Stream> GetStreamAsync(Uri requestUri)
		{
			return await Client.GetStreamAsync(requestUri);
		}

		public virtual async Task<string> GetStringAsync(string requestUri)
		{
			return await Client.GetStringAsync(requestUri);
		}

		public virtual async Task<string> GetStringAsync(Uri requestUri)
		{
			return await Client.GetStringAsync(requestUri);
		}

		public virtual async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			return await Client.PostAsync(requestUri, content);
		}

		public virtual async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return await Client.PostAsync(requestUri, content, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return await Client.PostAsync(requestUri, content);
		}

		public virtual async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return await Client.PostAsync(requestUri, content, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			return await Client.PutAsync(requestUri, content);
		}

		public virtual async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return await Client.PutAsync(requestUri, content, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return await Client.PutAsync(requestUri, content);
		}

		public virtual async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return await Client.PutAsync(requestUri, content, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return await Client.SendAsync(request);
		}

		public virtual async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return await Client.SendAsync(request, completionOption);
		}

		public virtual async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return await Client.SendAsync(request, completionOption, cancellationToken);
		}

		public virtual async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return await Client.SendAsync(request, cancellationToken);
		}

		public virtual void Dispose()
		{
			Client.Dispose();
		}
	}
}
