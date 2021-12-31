using System;
using System.Collections.Generic;
using System.Linq;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace helloLambda
{
    public class Function
    {
        /// <summary>
        /// Returns the letter combinations for a phone number.
        /// </summary>
        /// <param name="input">digits-only string</param>
        /// <param name="context">ILambdaContext</param>
        /// <returns>string array of letter combinations</returns>
        public IEnumerable<string> FunctionHandler(string digits, ILambdaContext context)
        {
            if (string.IsNullOrEmpty(digits) || digits.Any(c => c < '0' || c > '9')) { return new List<string>(); }

            context.Logger.LogLine($"Processing phone number {digits}");

            string[] phone = new string[] { "0", "1", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            var result = digits.Skip(1).Select(d => d - '0').Aggregate(phone[digits[0] - '0'].Select(c => c.ToString()), (acc, i) => phone[i].SelectMany(c => acc.Select(a => $"{a}{c}")));

            context.Logger.LogLine($"{result.Count()} letter combinations returned");
            return result;
        }
    }
}
