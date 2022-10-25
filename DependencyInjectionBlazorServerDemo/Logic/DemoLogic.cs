﻿namespace DependencyInjectionBlazorServerDemo.Logic;

public class DemoLogic : IDemoLogic
{
	public int Value1 { get; set; }
	public int Value2 { get; set; }
	public DemoLogic()
	{
		Value1 = Random.Shared.Next(1, 1001);
		Value2 = Random.Shared.Next(1, 1001);
	}
}
