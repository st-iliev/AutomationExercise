pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
     stage('Update NuGet Package') {
            steps {
                bat 'dotnet add package Selenium.WebDriver.ChromeDriver'
            }
        }
        stage('Build') {
            steps {
                bat 'dotnet restore "Automation Exercise.sln"'
                
                bat 'dotnet build "Automation Exercise.sln" --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                bat 'dotnet test "Automation Exercise/AutomationExercise.csproj" --configuration Release'
            }
        }
    }

    post {
        always {
            script {
                bat 'taskkill /F /IM chrome.exe'
            }
        }
    }
}
