pipeline {
    agent any
    environment {
        WORKSPACE_DIR = 'C:/Users/User/.jenkins/workspace/TEST_UI/AutomationExercise-UI-and-API/Automation Exercise.sln'
    }
    stages {
        stage('Debug Parameters') {
            steps {
                script {
                    echo "Received parameter trigger_auto with value: ${params.trigger_auto}"
                }
            }
        }
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Update NuGet Package') {
            steps {
                dir('C:/Users/User/.jenkins/workspace/TEST UI/Automation Exercise') {
                    bat 'dotnet add package Selenium.WebDriver.ChromeDriver'
                }
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
            // Publish the Allure report
           allure([
    results: [[path: 'C:\\Users\\User\\.jenkins\\workspace\\test\\allure-results']]
            ])
        }
    }
    }
}
