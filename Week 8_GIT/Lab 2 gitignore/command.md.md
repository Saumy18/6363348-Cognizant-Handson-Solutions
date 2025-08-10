**Using .gitignore to ignore files and folders**



Commands to Execute in Git Bash:



1. cd GitDemo
2. mkdir logs
3. echo "Log data" > logs/app.log
4. echo "\*.log" > .gitignore
5. echo "logs/" >> .gitignore
6. git status
7. git add .gitignore
8. git commit -m "Add .gitignore to ignore logs"
