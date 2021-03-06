/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.shelf.tactical.environment.VerifyDataPort;
using br.ufc.mdcc.hpc.shelf.tactical.environment.VerifyDataPortClientType;
using br.ufc.mdcc.hpc.storm.binding.task.TaskBindingBase;
using br.ufc.mdcc.hpc.shelf.tactical.task.VerifyPortType;
using br.ufc.mdcc.hpc.shelf.certifier.C4;
using br.ufc.mdcc.hpc.shelf.certify.ParallelCertificationSystemC4;

namespace br.ufc.mdcc.hpc.shelf.certify.ParallelCertificationSystemC4Impl 
{
	public abstract class BaseIRootImpl: Application, BaseIRoot
	{
		private IVerifyClientPort<IVerifyDataPortClientType> verify_data4 = null;

		protected IVerifyClientPort<IVerifyDataPortClientType> Verify_data4
		{
			get
			{
				if (this.verify_data4 == null)
					this.verify_data4 = (IVerifyClientPort<IVerifyDataPortClientType>) Services.getPort("verify_data4");
				return this.verify_data4;
			}
		}
		private IVerifyClientPort<IVerifyDataPortClientType> verify_data3 = null;

		protected IVerifyClientPort<IVerifyDataPortClientType> Verify_data3
		{
			get
			{
				if (this.verify_data3 == null)
					this.verify_data3 = (IVerifyClientPort<IVerifyDataPortClientType>) Services.getPort("verify_data3");
				return this.verify_data3;
			}
		}
		private IVerifyClientPort<IVerifyDataPortClientType> verify_data2 = null;

		protected IVerifyClientPort<IVerifyDataPortClientType> Verify_data2
		{
			get
			{
				if (this.verify_data2 == null)
					this.verify_data2 = (IVerifyClientPort<IVerifyDataPortClientType>) Services.getPort("verify_data2");
				return this.verify_data2;
			}
		}
		private IVerifyClientPort<IVerifyDataPortClientType> verify_data1 = null;

		protected IVerifyClientPort<IVerifyDataPortClientType> Verify_data1
		{
			get
			{
				if (this.verify_data1 == null)
					this.verify_data1 = (IVerifyClientPort<IVerifyDataPortClientType>) Services.getPort("verify_data1");
				return this.verify_data1;
			}
		}
		private ITaskPort<IVerifyPortType> verify4 = null;

		protected ITaskPort<IVerifyPortType> Verify4
		{
			get
			{
				if (this.verify4 == null)
					this.verify4 = (ITaskPort<IVerifyPortType>) Services.getPort("verify4");
				return this.verify4;
			}
		}
		private ITaskPort<IVerifyPortType> verify3 = null;

		protected ITaskPort<IVerifyPortType> Verify3
		{
			get
			{
				if (this.verify3 == null)
					this.verify3 = (ITaskPort<IVerifyPortType>) Services.getPort("verify3");
				return this.verify3;
			}
		}
		private ITaskPort<IVerifyPortType> verify1 = null;

		protected ITaskPort<IVerifyPortType> Verify1
		{
			get
			{
				if (this.verify1 == null)
					this.verify1 = (ITaskPort<IVerifyPortType>) Services.getPort("verify1");
				return this.verify1;
			}
		}
		private ITaskPort<IVerifyPortType> verify2 = null;

		protected ITaskPort<IVerifyPortType> Verify2
		{
			get
			{
				if (this.verify2 == null)
					this.verify2 = (ITaskPort<IVerifyPortType>) Services.getPort("verify2");
				return this.verify2;
			}
		}
		private IC4 C4 = null;

		protected IC4 c4
		{
			get
			{
				if (this.C4 == null)
					this.C4 = (IC4) Services.getPort("C4");
				return this.C4;
			}
		}
	}
}