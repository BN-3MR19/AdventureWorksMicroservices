pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build YourApiProjectName.sln'
      }
    }
    stage('Docker Build') {
      steps {
        sh 'docker build -t your-api-image-name .'
      }
    }
    stage('Deploy to Staging') {
      steps {
        sh 'docker-compose up --build -d'
      }
    }
  }
}
