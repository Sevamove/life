package com.example.life.game.patterns;

import com.example.life.game.cell.Cell;
import com.example.life.game.cell.Position;
import com.example.life.game.cell.State;

public final class Beacon {
    private static final Cell[] cells = {
            new Cell(new Position(1, 1), State.LIVE),
            new Cell(new Position(2, 1), State.LIVE),
            new Cell(new Position(1, 2), State.LIVE),
            new Cell(new Position(2, 2), State.LIVE),
            new Cell(new Position(3, 3), State.LIVE),
            new Cell(new Position(4, 3), State.LIVE),
            new Cell(new Position(3, 4), State.LIVE),
            new Cell(new Position(4, 4), State.LIVE), };

    public static final Cell[] get() {
        return cells;
    }
}
