#!/bin/bash
# Adds newlines at end of file for files without

RED='\033[0;31m'
GREEN='\033[0;32m'
GREY='\033[0;30m'
RESET='\033[0m' # No Color

#files=$(find ./files -type f)
files=$(git ls-files)

for file in $files; do
    if [[ $(tail -c 1 "$file" | xxd -p) != 0a ]]; then
        echo -e "FIXING ${GREEN}$file${RESET}"
        echo >> $file

    else
        echo -e "${GREY}$file has newline${RESET}"
    fi
done
