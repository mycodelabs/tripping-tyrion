class WindowsService
  attr_accessor :service_name

  def initialize(service_name)
    @service_name = service_name
  end

  def install(bin_path)
  	install_command = "sc create #{@service_name} binPath= #{bin_path}"
  	`#{install_command}`
  end

  def stop()
  	stop_command = "sc stop #{@service_name}"
  	`#{stop_command}`
  end

  def delete()
  	delete_command = "sc delete #{@service_name}"
  	`#{delete_command}`
  end

  def start()
  	start_command = "sc start #{@service_name}"
  	`#{start_command}`
  end
end