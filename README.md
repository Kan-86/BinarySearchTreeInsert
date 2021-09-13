# BinarySearchTreeInsert
This is the project for Motarolla, Binary Search Tree API, with Unit tests

# How to run the docker and push it

1. docker build -t <docker-id>/<docker-image-name>
2. docker run -p 8080:80 <docker-id>/<docker-image-name>
3. docker push <docker-id>/<docker-image-name>


# Example values with response code 200

{
  "value": 5,
  "tree": {
    "value": 10,
    "left": {
      "value":3
    },
    "right": {
      "value": 12
    }
  }
}

# Example values with response code 400

{
  "value": 0,
  "tree": {
    "value": 0
  }
}

# Checks if the value already exists

{
  "value": 3,
  "tree": {
    "value": 10,
    "left": {
      "value":3
    },
    "right": {
      "value": 12
    }
  }
}


# Docker container deployed on Azure, there is a test method for getting a string

http://dockerbstapicontainer.francecentral.azurecontainer.io/api/BinarySearchTree