﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Microsoft.Playwright;


    using var playwright = await Playwright.CreateAsync();
    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
    var page = await browser.NewPageAsync();
    await page.GotoAsync("https://example.com");
    Console.WriteLine(await page.TitleAsync());
    await browser.CloseAsync();
