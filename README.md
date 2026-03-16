# apbd-cw1-git-s32771

Adding text to cause non fast-forward merge  

Merge was not fast-forward because there were changes on the original branch before merging  

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> b4670b4 (Update README)
Updating README before rebase 

Answers to questions:  
1.Git does a fast-forward merge when the main branch hasn't changed since you created your feature branch, so it simply moves the pointer forward. A merge commit is created instead when both branches have new commits that need to be joined together.  

2.Merge keeps the original history with all its branches and extra merge commits, and rebase rewrites the history into one clean, straight line

=======
Answers to questions:  
1.Git does a fast-forward merge when the main branch hasn't changed since you created your feature branch, so it simply moves the pointer forward. A merge commit is created instead when both branches have new commits that need to be joined together.  

2.Merge keeps the original history with all its branches and extra merge commits, and rebase rewrites the history into one clean, straight line
>>>>>>> 260cd8c (Add method CalculateMin)
