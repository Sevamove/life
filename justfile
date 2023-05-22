alias ces := create-empty-solution
alias inp := initialize-new-project
alias anp := add-new-project
alias rp := remove-project
alias run := run-project
alias d := dotnet

default:
    @just --list

pull:
    just -f ~/justfile switch-to-school-git-config \
    && git pull origin-school development

add *files="":
    git add {{files}}

commit message="":
    just -f ~/justfile switch-to-school-git-config \
    && git commit -m {{message}} \
    && just -f ~/justfile switch-to-personal-git-config

push branch="development":
    just -f ~/justfile switch-to-school-git-config \
    && git push -u origin-school {{branch}} \
    && just -f ~/justfile switch-to-personal-git-config \
    && git push -u origin-personal {{branch}}

create-new-gitignore:
    dotnet new gitignore

create-empty-solution solution_name:
    dotnet new sln --name {{solution_name}}

initialize-new-project project_name:
    dotnet new console -o {{project_name}}

add-new-project project_path:
    dotnet sln add {{project_path}}

run-project project_path:
    dotnet run --project {{project_path}}

remove-project project_path:
    dotnet sln remove {{project_path}}

dotnet *args="--help":
    dotnet {{args}}

test path="./test":
    dotnet test {{path}}