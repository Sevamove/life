# Conway's Game of Life

This is a .NET implementation of Conway's Game of Life, a cellular automaton devised by mathematician John Horton Conway.

## Rules of the Game

The Game of Life takes place on a two-dimensional grid of cells. Each cell can be either alive or dead. The game evolves through a series of generations based on the following rules:

1. Any live cell with fewer than two live neighbors dies, as if caused by underpopulation.
2. Any live cell with two or three live neighbors lives on to the next generation.
3. Any live cell with more than three live neighbors dies, as if by overpopulation.
4. Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

## How to Run

To run the Game of Life, you need to have .NET installed on your machine. Follow these steps:

1. Clone the repository or download the source code.
2. Open a command prompt or terminal and navigate to the project directory.
3. Run the following command to build the project:

```bash
dotnet build src/UI/Console
```

4. After a successful build, run the following command to start the application:

```bash
dotnet run --project src/UI/Console
```

## Customization

You can customize various aspects of the Game of Life by modifying the source code. Feel free to explore and experiment with different settings, such as grid size, initial patterns, or simulation speed.

## Contributing

Contributions are welcome! If you find any issues or have ideas for improvements, please submit an issue or a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
