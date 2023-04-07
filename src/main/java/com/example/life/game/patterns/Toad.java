package com.example.life.game.patterns;

import com.example.life.game.cell.Cell;
import com.example.life.game.cell.Position;
import com.example.life.game.cell.State;

public final class Toad {
    private static final Cell[] cells = {
            new Cell(new Position(2, 2), State.LIVE),
            new Cell(new Position(3, 2), State.LIVE),
            new Cell(new Position(4, 2), State.LIVE),
            new Cell(new Position(1, 3), State.LIVE),
            new Cell(new Position(2, 3), State.LIVE),
            new Cell(new Position(3, 3), State.LIVE), };

    public static final Cell[] get() {
        return cells;
    }
}
