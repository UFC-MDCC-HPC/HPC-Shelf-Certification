/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.shelf.tactical.environment.VerifyDataPort;
using br.ufc.mdcc.hpc.shelf.tactical.environment.VerifyDataPortServerType;
using br.ufc.mdcc.hpc.storm.binding.task.TaskBindingBase;
using br.ufc.mdcc.hpc.shelf.tactical.task.VerifyPortType;
using br.ufc.mdcc.hpc.shelf.certify.tactical.ISP;
using br.ufc.mdcc.hpc.shelf.tactical.environment.VerifyDataPortServerTypeC4;

namespace br.ufc.mdcc.hpc.shelf.certify.tactical.impl.ISPImpl 
{
	public abstract class BaseIISPImpl: Tactical, BaseIISP
	{
		private IVerifyServerPort<IVerifyDataPortServerTypeC4> verify_data = null;

		public IVerifyServerPort<IVerifyDataPortServerTypeC4> Verify_data
		{
			get
			{
				if (this.verify_data == null)
					this.verify_data = (IVerifyServerPort<IVerifyDataPortServerTypeC4>) Services.getPort("verify_data");
				return this.verify_data;
			}
		}
		private ITaskPort<IVerifyPortType> verify = null;

		public ITaskPort<IVerifyPortType> Verify
		{
			get
			{
				if (this.verify == null)
					this.verify = (ITaskPort<IVerifyPortType>) Services.getPort("verify");
				return this.verify;
			}
		}
	}
}