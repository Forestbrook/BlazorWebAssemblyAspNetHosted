using BlazorExample.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorExample.Client.Pages;

public partial class Weather
{
    private WeatherForecast[]? _forecasts;

    [Inject]
    private HttpClient Http { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await Http.GetFromJsonAsync<WeatherForecast[]> ("WeatherForecast");
    }
}