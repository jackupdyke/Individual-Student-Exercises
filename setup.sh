#!/bin/bash

## script modified 1/7/2022 - JWF - hardcoded  cbus, c-sharp, and cohort 16

# This script assumes the student's repo has been cloned manually. The student 
# should have logged onto GitLabg, found their repo and cloned it. During that process,
# any issues with credentials would have been resolved.

# The script will then prompt the user for name, email, cohort and bitbucket team before configuring
# their diff tool settings and setting the upstream repository.

echo
read -r -p "Enter your name (First Last): " name
read -r -p "Enter your email: " email

echo
echo "Setting Up Global Configuration Settings"

git config --global user.name "${name}"
git config --global user.email "${email}"
git config --global init.defaultBranch main


echo "Setting up Git Editors and Tools..."

git config --global core.editor "code -w -n"
git config --global diff.tool code
git config --global difftool.code.cmd "code -w -d \$LOCAL \$REMOTE"

echo
echo "Configuring Upstream..."

git remote add upstream "https://git.techelevator.com/campuses/cbus/jan-2022/c-sharp/instructor-code.git"
git config branch.master.mergeOptions "--no-edit"

echo "Done."
