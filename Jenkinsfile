pipeline {
    agent any
    parameters {
        string(name: 'trigger_auto', defaultValue: '', description: 'Trigger Job 2 if the condition is met')
    }

    environment {
        WORKSPACE_DIR = 'C:/Users/User/.jenkins/workspace/TEST_UI/Automation_Exercise'
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
            when {
                expression { params.trigger_auto == 'auto' }
            }
            steps {
                checkout scm
            }
        }

        stage('Update NuGet Package') {
            when {
                expression { params.trigger_auto == 'auto' }
            }
            steps {
                dir('C:/Users/User/.jenkins/workspace/TEST UI/Automation Exercise') {
                    bat 'dotnet add package Selenium.WebDriver.ChromeDriver'
                }
            }
        }

        stage('Build') {
            when {
                expression { params.trigger_auto == 'auto' }
            }
            steps {
                bat 'dotnet restore "Automation Exercise.sln"'
                bat 'dotnet build "Automation Exercise.sln" --configuration Release'
            }
        }

        stage('Run Tests') {
            when {
                expression { params.trigger_auto == 'auto' }
            }
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
