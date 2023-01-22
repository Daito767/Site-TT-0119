using Microsoft.JSInterop;
using System.Threading.Tasks;
using BlazorServer.Data;
using System;

namespace BlazorServer.Data
{
	public class BrowserService
	{
		private readonly IJSRuntime _js;

		public BrowserService(IJSRuntime js)
		{
			_js = js;
		}

		public async Task<BrowserDimension> GetDimensions()
		{
			return await _js.InvokeAsync<BrowserDimension>("getWindowDimensions");
		}

	}
}