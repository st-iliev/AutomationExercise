pipeline {
    agent any
parameters{
    booleanParam(name: 'trigger_auto', defaultValue: false, description: 'Trigger Job 2 if the condition is met')
    stages {
     stage('Check Job 1 Trigger') {
            steps {
                script {
                    // Check if the job was triggered manually
                    if (params.trigger_auto) {
                        return // Skip further checks and proceed to the next stages
                    }
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
            script {
                bat 'taskkill /F /IM chrome.exe'
            }
        }
    }
}
}
