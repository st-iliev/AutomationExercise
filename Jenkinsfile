pipeline {
    agent any
    parameters {
        booleanParam(name: 'trigger_auto', defaultValue: false, description: 'Trigger Job 2 if the condition is met')
    }

    stages {
        stage('Check Job 1 Trigger') {
            steps {
                script {
                    // Check if the job was triggered manually
                    if (params.trigger_auto) {
                        echo 'Job 2 is triggered manually. Skipping further checks.'
                        return // Skip further checks and proceed to the next stages
                    }
                    
                    def job1Name = 'start jenkins'
                    def job1 = Jenkins.instance.getItemByFullName(job1Name)

                    if (job1) {
                        def lastBuild = job1.getLastBuild()

                        if (lastBuild) {
                            def triggerCause = lastBuild.getAction(hudson.model.ParametersAction)?.parameters?.find { it.name == 'trigger_mode' }?.value

                            if (triggerCause == 'auto') {
                                echo 'Job 1 was triggered automatically. Proceeding to trigger Job 2.'
                                
                                // Trigger Job 2 with a parameter to distinguish automated triggers
                                build job: 'TEST UI', parameters: [booleanParam(name: 'AUTOMATED_TRIGGER', value: true)]
                            } else {
                                echo 'Job 1 was not triggered automatically or parameter not found.'
                            }
                        } else {
                            echo 'No builds found for Job 1.'
                        }
                    } else {
                        error 'Job 1 not found.'
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
