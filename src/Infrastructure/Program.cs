﻿using Infrastructure;
using Infrastructure.Adapters;
using Infrastructure.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(Directory.GetCurrentDirectory());

// var v = new JsonFileAdapter<GameEntity>(Config.DB_URL);
// var r = new PatternRepository(v);
// Console.WriteLine("1");
// List<GameEntity> p = new List<GameEntity>() { new GameEntity
// {
// 	Name = "ff",
// 	Id = "ss",
// 	MinimumAreaNeeded = new Area(20, 20),
// 	Cells = new Cell[] {
// 				new Cell(new Position(0, 1), State.LIVE),
// 				new Cell(new Position(1, 2), State.LIVE),
// 				new Cell(new Position(2, 0), State.LIVE),
// 				new Cell(new Position(2, 1), State.LIVE),
// 				new Cell(new Position(2, 2), State.LIVE)}
// }};

// Console.WriteLine("2");
// r.SaveAllAsync(p);