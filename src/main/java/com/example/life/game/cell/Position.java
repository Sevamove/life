package com.example.life.game.cell;

public class Position {
    private static final int SURROUNDED_POSITIONS_AMOUNT = 8;
    private final int x;
    private final int y;

    public Position(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public static final Position[] getSurrounded(Position position) {
        Position[] positions = new Position[SURROUNDED_POSITIONS_AMOUNT];

        positions[0] = up(position);
        positions[1] = down(position);
        positions[2] = left(position);
        positions[3] = right(position);
        positions[4] = upLeft(position);
        positions[5] = upRight(position);
        positions[6] = downLeft(position);
        positions[7] = downRight(position);

        return positions;
    }

    public int x() {
        return this.x;
    }

    public int y() {
        return this.y;
    }

    static final private Position up(Position position) {
        return new Position(position.x - 1, position.y);
    }

    static final private Position down(Position position) {
        return new Position(position.x + 1, position.y);
    }

    static final private Position left(Position position) {
        return new Position(position.x, position.y - 1);
    }

    static final private Position right(Position position) {
        return new Position(position.x, position.y + 1);
    }

    static final private Position upLeft(Position position) {
        return new Position(position.x - 1, position.y - 1);
    }

    static final private Position upRight(Position position) {
        return new Position(position.x - 1, position.y + 1);
    }

    static final private Position downLeft(Position position) {
        return new Position(position.x + 1, position.y - 1);
    }

    static final private Position downRight(Position position) {
        return new Position(position.x + 1, position.y + 1);
    }
}
