using System;
using Models.Core;
using Models.Core.Run;
using Models.Factorial;
using Models.Graph;
using Models.Storage;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    /// <summary>
    /// This script must implement the IGraphPanelScript interface.
    /// </summary>
    [Serializable]
    public class Script : Model, IGraphPanelScript
    {
    /// <summary>
        /// Gets a list of simulation names. One tab of graphs will be generated for each simulation.
        /// </summary>
        /// <param name="storage">Provides access to the datastore.</param>
        /// <param name="panel">Provides access to the graph panel and the simulations tree.</param>
    public string[] GetSimulationNames(IStorageReader reader, GraphPanel panel)
    {
    // Get a list of all descendants of the panel's parent which are runnable
    // (simulations, experiments, etc).
    List<ISimulationDescriptionGenerator> runnables = Apsim.ChildrenRecursively(panel.Parent, typeof(ISimulationDescriptionGenerator)).Cast<ISimulationDescriptionGenerator>().ToList();

    // Remove all simulations which are children of an experiment.
    runnables.RemoveAll(r => r is Simulation && (r as Simulation).Parent is Experiment);

    // Return the names of all simulations generated by these runnables.
    return runnables.SelectMany(r => r.GenerateSimulationDescriptions().Select(d => d.Name)).ToArray();
    }

        /// <summary>
        /// Called on each graph before it is drawn in a tab.
        /// </summary>
        /// <param name="graph">The graph.</param>
        /// <param name="simulationName">Simulation name for this tab.</param>
        public void TransformGraph(Models.Graph.Graph graph, string simulationName)
        {
            foreach (Series series in Apsim.Children(graph, typeof(Series)))
            series.Name = series.Name.Replace("Predicted", "").Replace("Observed", "").Trim();
        }
    }
}