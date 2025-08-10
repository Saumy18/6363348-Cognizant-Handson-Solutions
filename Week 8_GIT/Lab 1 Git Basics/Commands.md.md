**Git Basics + Notepad++ Integration + Add file to repo**



Commands to Execute in Git Bash:



1. git config --global user.name "Your Name"
2. git config --global user.email "you@example.com"
3. git config --global core.editor "'notepad++.exe' -multiInst -nosession"
4. git init GitDemo
5. cd GitDemo
6. echo "Welcome to GitDemo" > welcome.txt
7. git status
8. git add welcome.txt
9. git commit -m "Add welcome.txt"
10. git remote add origin <your-remote-repo-url>
11. git push origin master
