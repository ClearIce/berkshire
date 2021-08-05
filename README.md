    docker build -t berkshire:latest .

    docker run -p 80:80 -p 443:443 -p 44390:44390 berkshire:latest