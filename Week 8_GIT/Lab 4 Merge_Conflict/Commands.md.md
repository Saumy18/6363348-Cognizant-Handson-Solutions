**Merge Conflict Resolution**



Commands to Execute in Git Bash:



1. cd GitDemo
2. git checkout -b GitWork
3. echo "Branch hello" > hello.xml
4. git add hello.xml
5. git commit -m "Add hello.xml in branch"
6. git checkout master
7. echo "Master hello" > hello.xml
8. git add hello.xml
9. git commit -m "Add hello.xml in master"
10. git merge GitWork
11. \# Resolve conflict in editor
12. git add hello.xml
13. git commit -m "Resolve merge conflict"
14. git branch -d GitWork
