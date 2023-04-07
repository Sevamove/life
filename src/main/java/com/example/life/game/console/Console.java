package com.example.life.game.console;

import com.example.life.game.cell.Cell;
import com.example.life.game.cell.State;
import com.example.life.game.grid.Area;

public class Console {
    private final static String liveCellIcon = "🟦";
    private final static String deadCellIcon = "⬜️";
    private final Area area;
    private final int fps;

    public Console(int fps, Area area) {
        this.area = area;
        this.fps = fps;
    }

    public final void clear() {
        try {
            if (System.getProperty("os.name").contains("Windows")) {
                new ProcessBuilder("cmd", "/c", "cls").inheritIO().start()
                        .waitFor();
            } else {
                System.out.print("\033[H\033[2J");
                System.out.flush();
            }
        } catch (Exception e) {
            // Handle exceptions here
        }
    }

    public final void display(Cell[][] cells) {
        for (int x = 0; x < this.area.width(); x++) {
            for (int y = 0; y < this.area.height(); y++) {
                boolean isCellAlive = cells[x][y].getState() == State.LIVE;

                System.out.print(isCellAlive ? liveCellIcon : deadCellIcon);
            }
            System.out.println();
        }
        System.out.println();
    }

    public final void delay() {
        long frameDelay = 1000 / this.fps;

        try {
            Thread.sleep(frameDelay);
        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }
}
