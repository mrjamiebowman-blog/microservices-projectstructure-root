# .NET Microservices Project Structure with Git Submodules
This is part of a blog post that explains how to use Git Submodules, .NET Aspire and demonstrates a way of organizing and structuring Visual Studio to accommodate those.   

## WIP: Note
This is currently a work in progress. The repos may not build and run yet with .NET Aspire. (02/12/2024). Please use this structure as a guideline.   

### Projects (Git Submodules)
* Console App
* API
* Common Library

## Getting Started

### Recursive Clone
```cli
git clone --recurse-submodules git@github.com:mrjamiebowman-blog/microservices-projectstructure-root.git
cd microservices-projectstructure-root
```

### Clone & Init, Update
```cli
git clone git@github.com:mrjamiebowman-blog/microservices-projectstructure-root.git
cd microservices-projectstructure-root

# initialize submodules
git submodule update --init --recursive

# update all submodules
git submodule update --recursive --remote
```
