﻿using LibraryWebAppClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace LibraryWebAppClient.Controllers
{
    public class BookClientController : Controller
    {
        public async Task<IActionResult> GetAllBooks()
        {
            HttpClient client = new ();
            client.BaseAddress = new Uri("https://localhost:7009");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            HttpResponseMessage response = await client.GetAsync("api/Books/get-all-books");
            if (response.IsSuccessStatusCode)
            {
                var books = await response.Content.ReadFromJsonAsync<IEnumerable<BookClient>>();
                return View(books);
            }
            return View();
        }
    }
}
