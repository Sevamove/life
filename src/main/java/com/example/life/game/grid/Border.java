package com.example.life.game.grid;

import com.example.life.game.cell.Position;

public final class Border {
    private Area area;

    public Border(Area area) {
        this.area = area;
    }

    public boolean isAt(Position position) {
        boolean isUpper = this.isUpper(position);
        boolean isLower = this.isLower(position);
        boolean isLeft = this.isLeft(position);
        boolean isRight = this.isRight(position);

        return (isUpper || isLower || isLeft || isRight);
    }

    private boolean isUpper(Position position) {
        return position.x() == -1 ? true : false;
    }

    private boolean isLower(Position position) {
        return position.x() == this.area.height() ? true : false;
    }

    private boolean isLeft(Position position) {
        return position.y() == -1 ? true : false;
    }

    private boolean isRight(Position position) {
        return position.y() == this.area.width() ? true : false;
    }
}
