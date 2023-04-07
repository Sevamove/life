package com.example.life.game.grid;

import com.example.life.game.cell.Cell;
import com.example.life.game.cell.Position;
import com.example.life.game.cell.State;

public final class Grid {
    private final Border border;
    private final Area area;
    private Cell[][] cells;

    public Grid(Area area) {
        this.area = area;
        this.cells = new Cell[area.width()][area.height()];
        this.border = new Border(area);
    }

    public final void initialize() {
        // Loop through the 2D-grid, row by row, column by column.
        for (int x = 0; x < this.cells.length; x++) {
            for (int y = 0; y < this.cells[x].length; y++) {
                // Populate grid with a cell.
                this.cells[x][y] = new Cell(new Position(x, y), State.DEAD);
            }
        }
    }

    public final void renew() {
        Cell[][] newCells = new Cell[this.area.width()][this.area.height()];

        for (int x = 0; x < this.area.width(); x++) {
            for (int y = 0; y < this.area.height(); y++) {
                newCells[x][y] = this.updateCell(new Position(x, y));
            }
        }

        this.cells = newCells;
    }

    public final void update(Cell[] cells) {
        for (int i = 0; i < cells.length; i++) {
            Cell cell = cells[i];

            int x = cell.getPosition().x();
            int y = cell.getPosition().y();

            this.cells[x][y] = cell;
        }
    }

    public final Cell getCell(Position position) {
        return this.cells[position.x()][position.y()];
    }

    public final Cell[][] getCells() {
        return this.cells;
    }

    private final Cell updateCell(Position position) {
        Cell cell = null; // TODO: handle null
        int amount = this.getNeighborsAmount(position);

        try {
            cell = (Cell) this.getCell(position).clone();

            cell.setState(amount);
        } catch (CloneNotSupportedException e) {
            // TODO: handle exception
            e.printStackTrace();
        }

        return cell;
    }

    private final int getNeighborsAmount(Position position) {
        int result = 0;
        Position[] positions = Position.getSurrounded(position);

        for (int i = 0; i < positions.length; i++) {
            if (!this.border.isAt(positions[i])) {
                result += this.getCell(positions[i]).getState().ordinal();
            }
        }

        return result;
    }
}
