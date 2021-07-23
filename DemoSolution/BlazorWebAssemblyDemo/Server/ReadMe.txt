Builds Docker image.
- docker build -t blazorwebassemblydemoserver -f Dockerfile .

Runs Docker container.
- docker run -d -p 8080:80 blazorwebassemblydemoserver