pipeline {
    agent any

    stages {
        stage('Check Job 1 Trigger') {
            steps {
                script {
                    // Name of the first job
                    def job1 = Jenkins.instance.getItemByFullName('start jenkins')
                    
                    // Get the last build of Job 1
                    def lastBuild = job1.getLastBuild()

                    // Check the cause of the last build trigger
                    def triggerCause = lastBuild.getAction(hudson.model.ParametersAction)?.parameters?.find { it.name == 'trigger_mode' }?.value

                    // Check if the parameter value is 'auto'
                    if (triggerCause == 'auto') {
                        echo 'Job 1 was triggered automatically. Proceeding to trigger Job 2.'

                        // Trigger Job 2
                        build job: 'TEST UI'
                    } else {
                        echo 'Job 1 was not triggered automatically or parameter not found.'
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
