node { 
    stage('Build') { 
        dotnet build
    }
    stage('Test') {
        cd GroceriesTesting
        dotnet test
    }
    if (currentBuild.currentResult == 'SUCCESS') {
        stage('Deploy') {
            echo "Fue un exito!!"
        }
    }
}