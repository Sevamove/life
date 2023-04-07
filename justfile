docker:
    docker compose up -d

docker-ps:
    docker compose ps

d-logs:
    docker logs postgres -f

# Then: psql -U user -> \l -> CREATE DATABASE customer;
# Also: \c customer -> \dt -> \d
sql-console:
    docker exec -it postgres bash
     