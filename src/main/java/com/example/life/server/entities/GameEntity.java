package com.example.life.server.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.SequenceGenerator;
import jakarta.persistence.Table;

@Table(name = "game")
@Entity
public class GameEntity {
    @Id
    @SequenceGenerator(name = "game_id_sequence", sequenceName = "game_id_sequence", allocationSize = 1)
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "game_id_sequence")
    private Long id;
    private String name;
}
