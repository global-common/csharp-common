#! /usr/bin/env bash
antlr4.sh JSON5.g4 -Dlanguage=CSharp -package Global.Parser.Json5 -o Parser/Json5
