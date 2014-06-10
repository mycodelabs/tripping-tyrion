namespace mars_rovers_project.container
{
    public class ObjectFactory
    {
        public class expression
        {
            public static ExpressionBuilder<target> to_target<target>()
            {
                return new ExpressionBuilder<target>();
            }
        }
    }
}