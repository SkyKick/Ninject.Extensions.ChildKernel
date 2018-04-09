namespace Ninject.Extensions.ChildKernel
{
    /// <summary>
    /// Another test object
    /// </summary>
    public class Bar : IBar, IInitializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bar"/> class.
        /// </summary>
        /// <param name="name">The name of the instance.</param>
        public Bar(string name)
        {
            Name = name;
            ActivationCount = 0;
        }

        /// <summary>
        /// Gets the number of activations.
        /// </summary>
        /// <value>The activation count.</value>
        public int ActivationCount { get; private set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        /// <value>The name of the instance.</value>
        public string Name { get; }

        /// <summary>
        /// Initializes the instance. Called during activation.
        /// </summary>
        public void Initialize()
        {
            ActivationCount++;
        }
    }
}