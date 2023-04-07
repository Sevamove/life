package com.example.life.game;

import com.example.life.game.cell.Cell;
import com.example.life.game.console.Console;
import com.example.life.game.grid.Area;
import com.example.life.game.grid.Grid;
import com.example.life.game.patterns.Pulsar;

public final class Game {
    // private Grid grid;

    // public Game(Grid grid) {
    // this.grid = grid;
    // }

    // public void start() {
    // this.grid.initialize();
    // }

    // public void load(Cell[] cells) {
    // this.grid.update(cells);
    // }

    // public void renew() {
    // this.grid.renew();
    // }

    public static void main(String[] args) {
        Area area = new Area(20, 20);
        Console console = new Console(1, area);
        Grid grid = new Grid(area);

        grid.initialize();

        Cell[] cells = Pulsar.get();

        grid.update(cells);

        while (true) {
            console.clear();
            console.display(grid.getCells());

            grid.renew();

            console.delay();
        }
    }
}