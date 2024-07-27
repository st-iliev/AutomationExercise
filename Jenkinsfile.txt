pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Clone the GitHub repository
                checkout scm
            }
        }

        stage('Build') {
            steps {
                // Restore dependencies
                bat 'dotnet restore "Automation Exercise.sln"'
                
                // Build the project
                bat 'dotnet build "Automation Exercise.sln" --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                bat 'dotnet test "Automation Exercise/AutomationExercise.csproj" --configuration Release'
                }
            }
        }
    }

    post {
        always {
            // Terminate Chrome process after tests
            script {
                    bat 'taskkill /F /IM chrome.exe'
                    bat 'taskkill /F /IM chromedriver.exe'
                }
            }
        }
    }
}
