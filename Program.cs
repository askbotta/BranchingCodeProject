using BranchingCodeProject;

public class Hello2
{
    static void Main()
    {
        Student student = new Student();
        student.StudentList();

        Student1 student1 = new Student1();
        student1.StudentList();

        IfClassSample1 ifClassSample1 = new IfClassSample1();
        ifClassSample1.Sample1();

        IfElseSample2 ifElseSample2 = new IfElseSample2();
        ifElseSample2.IfElsesample();

        ExpressionEqualityOperator expressionEqualityOperator = new ExpressionEqualityOperator();
        expressionEqualityOperator.EqualityOperator();

        ConditionalOperatorSample conditionalOperatorSample = new ConditionalOperatorSample();
        conditionalOperatorSample.ConditionalOperatorSample1();

        DisplayResultOfFlipCoin displayResultOfFlipCoin = new DisplayResultOfFlipCoin();
        displayResultOfFlipCoin.CointProject();

        DecisionLogic decisionLogic = new DecisionLogic();
        decisionLogic.InitializePermission();
    }
}
