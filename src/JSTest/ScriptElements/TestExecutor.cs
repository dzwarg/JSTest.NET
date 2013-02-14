﻿using System;

/* Copyright (c) 2011 CBaxter
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
 * IN THE SOFTWARE. 
 */

namespace JSTest.ScriptElements
{
    public class TestExecutor : ScriptBlock
    {
        private const String UnformattedScriptBlock =
          @"(function () {{
  try {{
    WScript.Echo(JSON.stringify((function () {{
      // START TEST BLOCK //
{0}
{1}
{2}
      // END TEST BLOCK //
      return null;
    }})()));
    WScript.Quit(0);
  }}
  catch (ex) {{
    WScript.Echo(JSON.stringify(ex));
    WScript.Quit(1);
  }}
}})();";

        public TestExecutor(String test)
            : base(String.Format(UnformattedScriptBlock, String.Empty, test, String.Empty))
        { }

        public TestExecutor(String setup, String test, String teardown)
            : base(String.Format(UnformattedScriptBlock, setup, test, teardown))
        { }
    }
}