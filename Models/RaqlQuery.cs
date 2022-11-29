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
        bool valid = true;
        private int line;
        private int charPositionInLine;
        private string message;

        public RAQLParser.ClauseContext Clause { get; private set; }

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

        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            valid = false;
            this.line = line;
            this.charPositionInLine = charPositionInLine;
            this.message = msg;
        }
    }
}
