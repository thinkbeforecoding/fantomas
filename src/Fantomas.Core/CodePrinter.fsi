﻿module internal Fantomas.Core.CodePrinter

/// This type consists of contextual information which is important for formatting
/// Please avoid using this record as it can be the cause of unexpected behavior when used incorrectly
type ASTContext =
    {
        /// This pattern matters for formatting extern declarations
        IsCStylePattern: bool

        /// A field is rendered as union field or not
        IsUnionField: bool

        /// First type param might need extra spaces to avoid parsing errors on `<^`, `<'`, etc.
        IsFirstTypeParam: bool

        /// Inside a SynPat of MatchClause
        IsInsideMatchClausePattern: bool
    }

    static member Default: ASTContext

val genParsedInput:
    astContext: ASTContext -> ast: FSharp.Compiler.Syntax.ParsedInput -> (Context.Context -> Context.Context)
