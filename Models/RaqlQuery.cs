using Antlr4.Runtime;
using Microsoft.AspNetCore.Mvc;
using RAQL.NET.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAQL.NET.Models
{
    /// <summary>
    /// Raql Query Model
    /// </summary>
    /// <exception cref="InvalidDataException">The query is not well formed</exception>
    [ModelBinder(BinderType = typeof(RaqlQueryModelBinder))]
    public class RaqlQuery :IAntlrErrorListener<IToken>
    {
        /// <summary>
        /// The valid
        /// </summary>
        bool valid = true;
        /// <summary>
        /// The line
        /// </summary>
        private int line;
        /// <summary>
        /// The char position in line
        /// </summary>
        private int charPositionInLine;
        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// Gets or sets the value of the clause
        /// </summary>
        public RAQLParser.ClauseContext Clause { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaqlQuery"/> class
        /// </summary>
        /// <param name="query">The query</param>
        /// <exception cref="InvalidDataException">The provided query in not well formed. line: {line}, position: {charPositionInLine}.\n{message}</exception>
        public RaqlQuery(string query)
        {
            AntlrInputStream inputStream = new AntlrInputStream(query);
            RAQLLexer lexer = new RAQLLexer(inputStream);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            RAQLParser parser = new RAQLParser(tokenStream);
            parser.AddErrorListener(this);
            var raql = parser.raql();
            if (!valid)
            {
                throw new InvalidDataException($"The provided query in not well formed. line: {line}, position: {charPositionInLine}.\n{message}");
            }
            else
            {
                Clause = raql.clause();
            }
        }

        public static implicit operator RaqlQuery(string query)
        {
            return new RaqlQuery(query);
        }

        /// <summary>
        /// Syntaxes the error using the specified output
        /// </summary>
        /// <param name="output">The output</param>
        /// <param name="recognizer">The recognizer</param>
        /// <param name="offendingSymbol">The offending symbol</param>
        /// <param name="line">The line</param>
        /// <param name="charPositionInLine">The char position in line</param>
        /// <param name="msg">The msg</param>
        /// <param name="e">The </param>
        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            valid = false;
            this.line = line;
            this.charPositionInLine = charPositionInLine;
            this.message = msg;
        }
    }
}
