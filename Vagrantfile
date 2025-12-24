Vagrant.configure("2") do |config|

  config.vm.box = "ubuntu/focal64"

  config.vm.provision "shell", inline: <<-SHELL
    # 1. Завантажуємо пакет налаштувань репозиторіїв Microsoft
    wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    sudo dpkg -i packages-microsoft-prod.deb
    rm packages-microsoft-prod.deb

   
    sudo apt update
    sudo apt install -y dotnet-sdk-7.0 git

    
    if [ ! -d "StudentAnalytics" ]; then
      git clone https://github.com/Anton6346/StudentAnalytics.git
    fi
    
    cd StudentAnalytics/StudentAnalytics.App
    dotnet run
  SHELL

end