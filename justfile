alias ces := create-empty-solution
alias inp := initialize-new-project
alias anp := add-new-project
alias rp := run-project
alias d := dotnet

default:
    @just --list

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

dotnet *args="--help":
    dotnet {{args}}
