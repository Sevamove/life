package com.example.life.game.cell;

public class Cell implements Cloneable {
    private Position position;
    private State state;

    public Cell(Position position, State state) {
        this.position = position;
        this.state = state;
    }

    public void setState(int neighborsAmount) {
        if (this.shouldLive(neighborsAmount)
                || this.shouldBorn(neighborsAmount)) {
            this.state = State.LIVE;
        }

        if (this.shouldDie(neighborsAmount)) {
            this.state = State.DEAD;
        }
    }

    public Position getPosition() {
        return this.position;
    }

    public State getState() {
        return this.state;
    }

    private boolean shouldLive(int neighborsAmount) {
        boolean isAlive = this.state == State.LIVE;
        boolean isRemainedAlive = neighborsAmount == 2 || neighborsAmount == 3;

        if (isAlive && isRemainedAlive) {
            return true;
        }

        return false;
    }

    private boolean shouldBorn(int neighborsAmount) {
        boolean isDead = this.state == State.DEAD;
        boolean isReproduced = neighborsAmount == 3;

        if (isDead && isReproduced) {
            return true;
        }

        return false;
    }

    private boolean shouldDie(int neighborsAmount) {
        boolean isUnderpopulated = neighborsAmount < 2;
        boolean isOverpopulated = neighborsAmount > 3;

        if (isUnderpopulated || isOverpopulated) {
            return true;
        }

        return false;
    }

    @Override
    public Object clone() throws CloneNotSupportedException {
        Cell cellCloned = (Cell) super.clone();
        // add any additional cloning instructions here, if necessary
        return cellCloned;
    }
}
