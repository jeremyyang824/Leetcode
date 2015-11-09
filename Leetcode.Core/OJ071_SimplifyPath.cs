using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an absolute path for a file (Unix-style), simplify it.
     * For example,
     * path = "/home/", => "/home"
     * path = "/a/./b/../../c/", => "/c"
     * 
     * Corner Cases:
     * Did you consider the case where path = "/../"?
     * In this case, you should return "/".
     * Another corner case is the path might contain multiple slashes '/' together, such as "/home//foo/".
     * In this case, you should ignore redundant slashes and return "/home/foo".
     */
    public class OJ071_SimplifyPath
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            char[] pathArr = path.ToCharArray();
            int len = pathArr.Length;
            for (int i = 0; i < len; i++)
            {
                //1.忽略'/'
                while (i < len && pathArr[i] == '/')
                    i++;

                //2.记录当前目录名
                string name = "";
                while (i < len && pathArr[i] != '/')
                    name += pathArr[i++];

                //3.入栈or退栈
                if (name == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if (name != "." && name != "")
                {
                    stack.Push(name);
                }
            }

            if (stack.Count == 0)
                return "/";

            string s = "";
            while (stack.Count > 0)
            {
                s = "/" + stack.Pop() + s;
            }
            return s;
        }
    }
}
