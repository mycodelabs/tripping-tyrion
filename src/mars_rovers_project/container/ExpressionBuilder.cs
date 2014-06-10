using System;
using System.Linq.Expressions;
using System.Reflection;

namespace mars_rovers_project.container
{
    public class ExpressionBuilder<target>
    {
        public ConstructorInfo ctor_pointed_at_by(Expression<Func<target>> ctor)
        {
            return ((NewExpression) ctor.Body).Constructor;
        }
    }
}